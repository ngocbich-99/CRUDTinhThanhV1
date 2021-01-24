import { Component, Injector, OnInit, Output } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { CreateTinhThanhDto, PermissionDto, PermissionDtoListResultDto, TinhThanhDto, TinhThanhServiceServiceProxy } 
from '@shared/service-proxies/service-proxies';
import { EventEmitter } from '@angular/core';
import { forEach, map } from 'lodash-es';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs/operators';

@Component({
  templateUrl: './create-tinhthanh.component.html',
})
export class CreateTinhthanhComponent extends AppComponentBase implements OnInit {
  saving=false;
  tinhthanh=new TinhThanhDto();

  @Output() onSave = new EventEmitter<any>();

  constructor(
    injector: Injector,
    private _tinhthanhService: TinhThanhServiceServiceProxy,
    public bsModalRef:BsModalRef
  ) {
    super(injector);
  }

  ngOnInit(): void {
    this._tinhthanhService
    //   .getAllPermissions()
    //   .subscribe((result: PermissionDtoListResultDto) => {
    //     this.permissions = result.items;
    //     this.setInitialPermissionsStatus();
    //   });
  }

  save(): void {
    this.saving = true;

    const tinhthanh = new CreateTinhThanhDto();
    tinhthanh.init(this.tinhthanh);

    this._tinhthanhService
      .create(tinhthanh)
      .pipe(
        finalize(() => {
          this.saving = false;
        })
      )
      .subscribe(() => {
        this.notify.info(this.l('SavedSuccessfully'));
        this.bsModalRef.hide();
        this.onSave.emit();
      });
  }


}

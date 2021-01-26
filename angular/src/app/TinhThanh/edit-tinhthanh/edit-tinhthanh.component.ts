import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { EditTTDto, TinhThanhServiceServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-tinhthanh',
  templateUrl: './edit-tinhthanh.component.html',
  styleUrls: ['./edit-tinhthanh.component.css']
})
export class EditTinhthanhComponent extends AppComponentBase implements OnInit {
    saving = false;
    id: number;
    tinhThanh = new EditTTDto();
  
    @Output() onSave = new EventEmitter<any>();
  
    constructor(
      injector: Injector,
      private _tinhThanhService: TinhThanhServiceServiceProxy,
      public bsModalRef: BsModalRef
    ) {
      super(injector);
    }
  
    ngOnInit(): void {
       console.log(this.id);
       
      this._tinhThanhService
        .getTTForEdit(this.id)
        .subscribe(result => {
          // console.log(result);
          this.tinhThanh.id = this.id;
          this.tinhThanh.ma = result.ma;
          this.tinhThanh.ten = result.ten;
          this.tinhThanh.ghiChu = result.ghiChu;
        });
    }
  
  
    save(): void {
      this.saving = true;
  
      const tinhThanh = new EditTTDto();
      tinhThanh.init(this.tinhThanh);
  
      this._tinhThanhService
        .update(tinhThanh)
        // .pipe(
        //   finalize(() => {
        //     this.saving = false;
        //   })
        // )
        .subscribe(() => {
          this.notify.info(this.l('SavedSuccessfully'));
          this.bsModalRef.hide();
          this.onSave.emit();
        });
    }

}

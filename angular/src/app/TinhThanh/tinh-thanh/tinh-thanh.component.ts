import { Component, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
  PagedListingComponentBase,
  PagedRequestDto
} from '@shared/paged-listing-component-base';
import {
  TinhThanhServiceServiceProxy,
  TinhThanhDto,
  TinhThanhDtoPagedResultDto
} from '@shared/service-proxies/service-proxies';
import { CreateTinhthanhComponent } from '../create-tinhthanh/create-tinhthanh.component';


class PagedTinhThanhsRequestDto extends PagedRequestDto {
  keyword: string;
}

@Component({
  templateUrl: './tinh-thanh.component.html',
  animations: [appModuleAnimation()]
})
export class TinhThanhComponent extends PagedListingComponentBase<TinhThanhDto> {
  tinhThanhs: TinhThanhDto[] = [];
  keyword = '';

  
  constructor(
    injector: Injector,
    private _tinhThanhService: TinhThanhServiceServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedTinhThanhsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;

    this._tinhThanhService
      .getAll()
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: TinhThanhDtoPagedResultDto) => {
        this.tinhThanhs = result.items;
        console.log(this.tinhThanhs);
        this.showPaging(result, pageNumber);
      });

  }


  delete(tinhthanh: TinhThanhDto): void {
    abp.message.confirm(
      this.l('RoleDeleteWarningMessage', tinhthanh.ten),
      undefined,
      (result: boolean) => {
        if (result) {
          this._tinhThanhService
            .delete(tinhthanh.id)
            .pipe(
              finalize(() => {
                abp.notify.success(this.l('SuccessfullyDeleted'));
                this.refresh();
              })
            )
            .subscribe(() => {});
        }
      }
    );
  }

  createTinhThanh(): void {
    this.showCreateOrEditTinhThanhDialog();
  }

  // editRole(role: RoleDto): void {
  //   this.showCreateOrEditRoleDialog(role.id);
  // }

  showCreateOrEditTinhThanhDialog(id?: number): void {
    let createOrEditRoleDialog: BsModalRef;
    if (!id) {
      createOrEditRoleDialog = this._modalService.show(
        CreateTinhthanhComponent,
        {
          class: 'modal-lg',
        }
      );
    }
    // } else {
    //   createOrEditRoleDialog = this._modalService.show(
    //     EditRoleDialogComponent,
    //     {
    //       class: 'modal-lg',
    //       initialState: {
    //         id: id,
    //       },
    //     }
    //   );
    // }

    createOrEditRoleDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }
}

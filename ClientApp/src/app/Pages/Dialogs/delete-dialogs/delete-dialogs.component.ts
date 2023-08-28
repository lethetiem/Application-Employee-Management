import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-delete-dialogs',
  templateUrl: './delete-dialogs.component.html',
  styleUrls: ['./delete-dialogs.component.css'],
})
export class DeleteDialogsComponent {
  constructor(
    public dialogRef: MatDialogRef<DeleteDialogsComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {}

  onCancelClick(): void {
    this.dialogRef.close(false);
  }

  onConfirmClick(): void {
    this.dialogRef.close(true);
  }
}

import { FormArray, FormControl, FormGroup } from '@angular/forms';

export default class ValidateForm{
    static validateAllFormField(formGroup: FormGroup | FormArray) {
        Object.keys(formGroup.controls).forEach((field) => {
          const control = formGroup.get(field);
          if (control) {
            if (control instanceof FormControl) {
              control.markAsDirty({ onlySelf: true });
            } else if (
              control instanceof FormGroup ||
              control instanceof FormArray
            ) {
              this.validateAllFormField(control);
            }
          }
        });
      }
}
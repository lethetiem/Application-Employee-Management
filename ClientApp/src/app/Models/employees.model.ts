export interface Employees{
    id: string;
    fullName: string;
    email: string;
    phoneNumber: number;
    address: string;
    companyCategory: string;
    gender: Gender;
}

export enum Gender{
    Male = 'Male',
    Female = 'Female'
}
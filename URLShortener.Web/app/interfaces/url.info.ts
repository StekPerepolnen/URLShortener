export interface IUrlInfo {
    Id: number;
    Url: string;
    ShortUrl: string;
    CreateAt: number;
    ClicksCount: number;
}

//export class IUrlInfo implements IUrlInfo {
//    constructor(public Id: number,
//        public Name: string,
//        public Key: string,
//        public CreateAt: number,
//        public ClicksCount: number){
//    }
//}
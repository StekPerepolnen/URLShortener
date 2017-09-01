import { Component, OnChanges } from '@angular/core';
import { UrlService } from '../url.service/url.service'
import { IUrlInfo } from '../interfaces/url.info'

@Component({
    moduleId: module.id,
    selector: 'url-info-list',
    templateUrl: 'url.info.list.component.html',
    providers: [UrlService]
})

export class UrlInfoListComponent {
    urlsInfo: IUrlInfo[];

    statusMessage: string;

    constructor(private _urlService: UrlService) {
    }

    ngOnInit() {
        this._urlService.getUrlsInfo().subscribe((info) => this.urlsInfo = info.sort(function (a, b) {
            if (a.CreateAt < b.CreateAt)
                return 1;
            if (a.CreateAt > b.CreateAt)
                return -1;
            return 0;
        }));
    }
}

import { Component, OnChanges } from '@angular/core';
import { UrlService } from '../url.service/url.service'

@Component({
    moduleId: module.id,
    selector: 'url-shortener',
    templateUrl: 'url.shortener.component.html',
    providers: [UrlService]
})
export class UrlShortenerComponent {
    originalUrl: string = '';
    shortUrl: string = null;
    showAnswer: boolean = true;

    constructor(private _urlService: UrlService) {
    }

    shortenUrl(url: string): void {
        this.originalUrl = url;
        this._urlService.getShortUrl(url).subscribe((shortUrl) => this.shortUrl = shortUrl);
        console.log(this.originalUrl);
        console.log(this.shortUrl);
    }
}

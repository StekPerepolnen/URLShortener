import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, URLSearchParams, Headers } from '@angular/http'
import { IUrlInfo } from '../interfaces/url.info'
import { Observable } from 'rxjs/Observable'
import 'rxjs/add/operator/map'
import 'rxjs/add/operator/catch'

@Injectable()
export class UrlService {
    constructor(private _http: Http) {
    
    }
    getUrlsInfo(): Observable<IUrlInfo[]> {
        return this._http.get("http://localhost:38938/api/UrlsInfo")
            .map((response: Response) => <IUrlInfo[]>response.json())
            .catch(this.handleError);
    }

    getShortUrl(url: string): Observable<string> {
        let params: URLSearchParams = new URLSearchParams();
        params.append('url', url);
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ search: params, headers: headers });
        return this._http.post("http://localhost:38938/api/ShortUrl", url, options)
            .map((response: Response) => response.json())
            .catch(this.handleError);
    }

    handleError(error: Response) {
        console.error(error);

        return Observable.throw(error);
    }
}

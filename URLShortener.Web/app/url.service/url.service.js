"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var http_1 = require("@angular/http");
var Observable_1 = require("rxjs/Observable");
var app_config_1 = require("../app.config");
require("rxjs/add/operator/map");
require("rxjs/add/operator/catch");
var UrlService = /** @class */ (function () {
    function UrlService(_http, config) {
        this._http = _http;
        this.config = config;
    }
    UrlService.prototype.getUrlsInfo = function () {
        return this._http.get(String(this.config.getConfig('UrlsInfoApi')))
            .map(function (response) { return response.json(); })
            .catch(this.handleError);
    };
    UrlService.prototype.getShortUrl = function (url) {
        var params = new http_1.URLSearchParams();
        params.append('url', encodeURIComponent(url));
        //let headers = new Headers({ 'Content-Type': 'application/json' });
        var options = new http_1.RequestOptions({ search: params });
        return this._http.post(String(this.config.getConfig('ShortUrlApi')), url, options)
            .map(function (response) { return response.json(); })
            .catch(this.handleError);
    };
    UrlService.prototype.handleError = function (error) {
        console.error(error);
        return Observable_1.Observable.throw(error);
    };
    UrlService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.Http, app_config_1.AppConfig])
    ], UrlService);
    return UrlService;
}());
exports.UrlService = UrlService;
//# sourceMappingURL=url.service.js.map
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
var url_service_1 = require("../url.service/url.service");
var UrlInfoListComponent = (function () {
    function UrlInfoListComponent(_urlService) {
        this._urlService = _urlService;
    }
    UrlInfoListComponent.prototype.ngOnInit = function () {
        var _this = this;
        this._urlService.getUrlsInfo().subscribe(function (info) { return _this.urlsInfo = info.sort(function (a, b) {
            if (a.CreateAt < b.CreateAt)
                return 1;
            if (a.CreateAt > b.CreateAt)
                return -1;
            return 0;
        }); });
    };
    UrlInfoListComponent = __decorate([
        core_1.Component({
            moduleId: module.id,
            selector: 'url-info-list',
            templateUrl: 'url.info.list.component.html',
            providers: [url_service_1.UrlService]
        }),
        __metadata("design:paramtypes", [url_service_1.UrlService])
    ], UrlInfoListComponent);
    return UrlInfoListComponent;
}());
exports.UrlInfoListComponent = UrlInfoListComponent;
//# sourceMappingURL=url.info.list.component.js.map
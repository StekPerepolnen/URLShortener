"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var forms_1 = require("@angular/forms");
var http_1 = require("@angular/http");
var router_1 = require("@angular/router");
var app_component_1 = require("./app.component");
var search_string_component_1 = require("./search.string/search.string.component");
var shortener_answer_component_1 = require("./shortener.answer/shortener.answer.component");
var navmenu_component_1 = require("./navmenu/navmenu.component");
var footer_component_1 = require("./footer/footer.component");
var home_component_1 = require("./home/home.component");
var catalogue_component_1 = require("./catalogue/catalogue.component");
var url_info_list_component_1 = require("./url.info.list/url.info.list.component");
var url_shortener_component_1 = require("./url.shortener/url.shortener.component");
var appRoutes = [
    { path: "home", component: home_component_1.HomeComponent },
    { path: "catalogue", component: catalogue_component_1.CatalogueComponent },
    { path: "**", component: home_component_1.HomeComponent }
];
var AppModule = (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            imports: [platform_browser_1.BrowserModule, forms_1.FormsModule, http_1.HttpModule, router_1.RouterModule.forRoot(appRoutes)],
            declarations: [app_component_1.AppComponent, search_string_component_1.SearchStringComponent, shortener_answer_component_1.ShortenerAnswerComponent, navmenu_component_1.NavmenuComponent, footer_component_1.FooterComponent, home_component_1.HomeComponent, catalogue_component_1.CatalogueComponent, url_info_list_component_1.UrlInfoListComponent, url_shortener_component_1.UrlShortenerComponent],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map
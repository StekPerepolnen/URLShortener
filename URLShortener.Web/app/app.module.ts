import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { SearchStringComponent } from './search.string/search.string.component';
import { ShortenerAnswerComponent } from './shortener.answer/shortener.answer.component';
import { NavmenuComponent } from './navmenu/navmenu.component';
import { FooterComponent } from './footer/footer.component';
import { HomeComponent } from './home/home.component';
import { CatalogueComponent } from './catalogue/catalogue.component';
import { UrlInfoListComponent } from './url.info.list/url.info.list.component';
import { UrlShortenerComponent } from './url.shortener/url.shortener.component';

const appRoutes: Routes = [
    { path: "home", component: HomeComponent },
    { path: "catalogue", component: CatalogueComponent },
    { path: "**", component: HomeComponent }
]

@NgModule({
    imports: [BrowserModule, FormsModule, HttpModule, RouterModule.forRoot(appRoutes)],
    declarations: [AppComponent, SearchStringComponent, ShortenerAnswerComponent, NavmenuComponent, FooterComponent, HomeComponent, CatalogueComponent, UrlInfoListComponent, UrlShortenerComponent],
    bootstrap: [AppComponent]
})
export class AppModule { }
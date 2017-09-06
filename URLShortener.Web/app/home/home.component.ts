import { Component } from '@angular/core';
import { AppConfig } from '../app.config';

@Component({
    moduleId: module.id,
    selector: 'home-page',
    templateUrl: 'home.component.html'
})
export class HomeComponent {
    constructor(private config: AppConfig) {
    }

    title: string = 'Simplify your links';
}

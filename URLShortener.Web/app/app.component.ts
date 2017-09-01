import { Component, OnChanges } from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'my-app',
    templateUrl: 'app.component.html',
})
export class AppComponent  {
    title: string = 'Simplify your links';
    showAnswer: boolean = true;
}

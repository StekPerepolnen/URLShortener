import { Component, OnChanges } from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'my-app',
    templateUrl: 'app.component.html',
    //template: `<div>
    //            <h1>Hello {{name }}</h1>
    //            <my-employee>...</my-employee>
    //        </div>`
})
export class AppComponent  {
    title: string = 'Simplify your links';
    showAnswer: boolean = true;
}

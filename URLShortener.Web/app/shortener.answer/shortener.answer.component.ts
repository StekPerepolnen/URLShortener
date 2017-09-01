import { Component, OnChanges, Input } from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'shortener-answer',
    templateUrl: 'shortener.answer.component.html'
})
export class ShortenerAnswerComponent {
    @Input()
    shortUrl: string;
}

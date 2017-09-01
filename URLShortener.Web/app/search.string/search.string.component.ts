import { Component, OnChanges, Output, EventEmitter } from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'search-string',
    templateUrl: 'search.string.component.html'
})
export class SearchStringComponent implements OnChanges {
    placeholderText: string = 'Your original URL here';
    buttonText: string = 'Shorten URL';

    url: string = '';

    onClick(): void {
        console.log("onClickl");
        this.shortenUrlButtonClicked.emit(this.url);
        this.url = '';
    }

    @Output()
    shortenUrlButtonClicked: EventEmitter<string> = new EventEmitter<string>();

    ngOnChanges(): void {
        console.log('onChanges');
    }
}

import { GameService } from './game.service';
import { Injectable } from '@angular/core';
import { Topic } from './topic.service';

@Injectable({
    providedIn: 'root',
})
export class WordsService {
    constructor() {}

    getAllFromTopic(topic: Topic): { [word: string]: string } {
        return {
            Baggage: 'Csomag',
            Departure: 'Indulás',
            Arrival: 'Érkezés',
            Airport: 'Reptér',
            Holiday: 'Nyaralás',
        };
    }

    getRandomWords(topic: Topic): string[] {
        return [
            'Something',
            'Anything',
            'Something else',
            'Thing',
            'Stuff',
            'Place',
            'Word',
            'New word',
        ];
    }
}

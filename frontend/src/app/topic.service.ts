import { Injectable } from '@angular/core';

export type Topic = {
    title: string;
    description: string;
    id: string;
};

@Injectable({
    providedIn: 'root',
})
export class TopicService {
    constructor() {}

    getAll(): Topic[] {
        return [
            {
                title: 'Food',
                description:
                    'A vocabulary aimed to help you avoid embarrassment while going out to eat.',
                id: 'food',
            },
            {
                title: 'Family',
                description:
                    "Learn how to address your or your partner's family at gatherings.",
                id: 'family',
            },
            {
                title: 'Sports',
                description:
                    'These words will help you cheer for your favorite team.',
                id: 'housing',
            },
            {
                title: 'Gardening',
                description:
                    'Become an Oxford level green-thumb with this vocabulary.',
                id: 'gardening',
            },
            {
                title: 'Travel',
                description: 'Words related to traveling abroad.',
                id: 'travel',
            },
            {
                title: 'Clothing',
                description:
                    'Everything you need to know regarding fashion or about simply going shopping for clothes.',
                id: 'clothing',
            },
        ];
    }
}

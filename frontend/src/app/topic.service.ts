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
        description: 'desc',
        id: 'food',
      },
      {
        title: 'Family',
        description: 'desc',
        id: 'family',
      },
      {
        title: 'Housing',
        description: 'desc',
        id: 'housing',
      },
      {
        title: 'Gardening',
        description: 'desc',
        id: 'gardening',
      },
      {
        title: 'Travel',
        description: 'desc',
        id: 'travel',
      },
    ];
  }
}

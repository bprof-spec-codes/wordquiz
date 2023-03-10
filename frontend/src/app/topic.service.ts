import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TopicService {

  constructor() { }

  getAll() {
    return ["Food", "Family", "Housing", "Gardening", "Travel"]
  }
}

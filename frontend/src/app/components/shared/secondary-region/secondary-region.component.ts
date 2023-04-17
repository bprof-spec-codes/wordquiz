import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-secondary-region',
  templateUrl: './secondary-region.component.html',
  styleUrls: ['./secondary-region.component.scss'],
})
export class SecondaryRegionComponent {
  @Input() header!: string;
}

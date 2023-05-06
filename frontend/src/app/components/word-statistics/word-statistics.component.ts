import { Component, OnInit } from '@angular/core';
import { ChartDataset, ChartOptions, Color, LabelItem } from 'chart.js';
import {  BaseChartDirective  } from 'ng2-charts';
import {  baseColors  } from 'ng2-charts';
import { WordStatisticService } from 'src/app/services/word-statistic.service';

@Component({
  selector: 'app-word-statistics',
  templateUrl: './word-statistics.component.html',
  styleUrls: ['./word-statistics.component.scss']
})
export class WordStatisticsComponent implements OnInit {

    barChartOptions: ChartOptions = {
    responsive: true,
  };
  barChartLabels: Color[] = [];
  barChartType: string = 'bar';
  barChartLegend = true;
  barChartData: ChartDataset[] = [];

  constructor(private wordStatisticService: WordStatisticService) {}

  ngOnInit(): void {
    this.wordStatisticService.getWordStatistics().subscribe((statistics: any[]) => {
      this.barChartLabels = statistics.map((stat) => stat.wordName);
      console.log(statistics);
      this.barChartData = [
        {
          data: statistics.map((stat) => stat.correctCount),
          label: 'Correct',
        },
        {
          data: statistics.map((stat) => stat.wrongCount),
          label: 'Incorrect',
        },
      ];
    });
  }
}

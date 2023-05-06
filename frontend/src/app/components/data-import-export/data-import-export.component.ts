import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { saveAs } from 'file-saver';



@Component({
  selector: 'app-data-import-export',
  templateUrl: './data-import-export.component.html',
  styleUrls: ['./data-import-export.component.css']
})
export class DataImportExportComponent {


    constructor(private http: HttpClient) {}

  selectedDataType: string = 'topics';
  selectedFile: File | null = null;

  onFileSelected(event: any) {
    this.selectedFile = event.target.files[0];
  }

  uploadData() {
    if (this.selectedFile) {
      const formData = new FormData();
      formData.append('file', this.selectedFile, this.selectedFile.name);

      this.http.post(`/api/data/import/${this.selectedDataType}`, formData).subscribe(
        (res) => {
          console.log(res);
          alert('Data uploaded successfully');
        },
        (err) => {
          console.error(err);
          alert('Error uploading data');
        }
      );
    } else {
      alert('Please select a file to upload.');
    }
  }

  downloadData() {
    this.http.get(`/api/data/export/${this.selectedDataType}`, { responseType: 'blob' }).subscribe(
      (data) => {
        saveAs(data, `${this.selectedDataType}.json`);
      },
      (err) => {
        console.error(err);
        alert('Error downloading data');
      }
    );
  }

  ngOnInit(): void {}

}

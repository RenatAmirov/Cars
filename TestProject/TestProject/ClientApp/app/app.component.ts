import { Component } from '@angular/core';
import { Repository } from "./models/repository";
import { Car } from "./models/car.model";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

    constructor(private repo: Repository) { }

    get cars(): Car[] {
        return this.repo.cars;
    }
}

import { Component } from '@angular/core';
import { Repository } from "../models/repository";
import { Car } from "../models/car.model";
import { Router } from "@angular/router";

@Component({
    selector: "car-table",
    templateUrl: "carTable.component.html"
})

export class CarTableComponent {

    constructor(private repo: Repository,
                private router: Router) { }

    get cars(): Car[] {
        return this.repo.cars;
    }
}

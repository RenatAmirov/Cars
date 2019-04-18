import { Car } from "./car.model";

export class Repository {

    constructor() {
        this.cars = JSON.parse(document.getElementById("data").textContent);
    }

    cars: Car[]; 
}

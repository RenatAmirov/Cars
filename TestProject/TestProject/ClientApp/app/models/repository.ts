import { Car } from "./car.model";
import { Injectable } from "@angular/core";
import { Http } from "@angular/http";

@Injectable()
export class Repository {

  constructor(private http: Http) {
    this.getCar(10002);
  }

  getCar(id: number) {
    this.http.get("/api/cars/" + id)
      .subscribe(response => this.car = response.json());
  }

  car: Car; 
}

import { Car } from "./car.model";
import { Injectable } from "@angular/core";
import { Http } from "@angular/http";

@Injectable()
export class Repository {

  private carData: Car;

  constructor(private http: Http) {
    this.getCar(10002);
  }

  getCar(id: number) {
    this.http.get("/api/cars/" + id)
      .subscribe(response => {
        this.carData = response.json();
        console.log("Car Data Received");
      });
  }

  get car(): Car {
    console.log("Car Data Requested");
    return this.carData;
  }
}

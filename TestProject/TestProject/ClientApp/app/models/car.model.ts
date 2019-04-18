import { Garage } from "./garage.model";

export class Car {

    constructor(
      public id?: number,

      public title?: string,

      public garage?: Garage) { }
}

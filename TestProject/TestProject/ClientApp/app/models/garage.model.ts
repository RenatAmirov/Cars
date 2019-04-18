import { Area } from "./area.model";
import { Car } from "./car.model";

export class Garage {
    constructor(
      public garageId?: number,

      public name?: string,

      public area?: Area,
      public cars?: Car[] ) { }
}

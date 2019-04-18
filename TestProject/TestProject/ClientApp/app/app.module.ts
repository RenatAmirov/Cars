import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { AppComponent } from './app.component';
import { ModelModule } from "./models/model.module";
import { CarTableComponent } from "./structure/carTable.component"
import { RoutingConfig } from "./app.routing";

@NgModule({
    declarations: [AppComponent, CarTableComponent],
    imports: [BrowserModule, FormsModule, HttpModule, ModelModule, RoutingConfig],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }

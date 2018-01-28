import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpModule } from "@angular/http";
import { ConverterComponent } from "./converter.component";
import { Config } from "../common/Configuration";
import { ErrorHandler } from "../common/ErrorHandler";


@NgModule({

  declarations: [
    ConverterComponent
  ],

  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    ReactiveFormsModule
  ],

  providers: [
    ConverterComponent,
    Config,
    ErrorHandler
  ],

  bootstrap: [ConverterComponent]
})
export class ConverterModule {

}

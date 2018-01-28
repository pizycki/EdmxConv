import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { FormsModule } from "@angular/forms";
import { HttpModule } from "@angular/http";
import { RouterModule } from "@angular/router";
import { ToastModule } from "ng2-toastr/ng2-toastr";
import { HighlightJsModule, HighlightJsService } from "angular2-highlight-js";

import { AppComponent } from "./components/app/app.component";
import { ConverterComponent } from "./components/converter/index";
import { CodeblockComponent } from "./components/codeblock/codeblock.component";
import { DropdownComponent } from "./components/dropdown/dropdown.component";

@NgModule({
    declarations: [
        AppComponent,
        ConverterComponent,
        CodeblockComponent,
        DropdownComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        ToastModule.forRoot(),
        HighlightJsModule,
        RouterModule.forRoot([
            { path: "", redirectTo: "", pathMatch: "full" },
            { path: "**", redirectTo: "" }
        ])
    ],
    providers: [
        HighlightJsService
    ]
})
export class AppModuleShared {
}

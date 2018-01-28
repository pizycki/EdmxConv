import { Injectable } from "@angular/core";

@Injectable()
export class Config {
    get API_URL(): string | undefined {
        return "http://localhost:58863"; // process.env.API_URL;
    }
}
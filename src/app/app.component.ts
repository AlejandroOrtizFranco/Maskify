import { Component } from '@angular/core';
import { ConfigService } from './services/config.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Maskify';

  constructor(private service:ConfigService) {}

  result:string;
  stringToMask:string;

  callMaskify(){

    let stringToMaskify:string;

    stringToMaskify = this.stringToMask;

    this.service.postMask({stringToMaskify})
      .subscribe(arg => this.result = arg.result);

  }

}

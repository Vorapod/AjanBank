import { Component, OnInit } from '@angular/core';

@Component({
  // selector: '[app-servers]',
  // template: '<app-server></app-server><app-server></app-server>',
  // styles: [`
  //   p {
  //     color: blue;
  //   }
  //   `]
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}

import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-server',
  template: '<p>The Server Component</p>',
  styles: [`
  p {
    color: blue;
  }
  `]
})
export class ServerComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}

import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  public eventos : any = [];
  exibirImagem = true;
  margemImagem =2
  larguraImagem = 50
  constructor(private httpClient: HttpClient) { }

  ngOnInit() {
    this.getEventos();
  }
  public getEventos():void{
    this.httpClient.get('https://localhost:5001/api/eventos').subscribe(
      response=> this.eventos = response,
      error => console.log(error),
    );
  }

}

import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos : any = [];
  public listaEventosFiltrada : any = [];
  exibirImagem = true;
  margemImagem =2
  larguraImagem = 150
  private _filtroLista='';

  public get filtroLista() : string {
    return this._filtroLista;
  }
  public set filtroLista(eventos : string) {
    this._filtroLista = eventos;
    this.listaEventosFiltrada = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
  }

  filtrarEventos(filtrarPor : string): any{
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (evento:any) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }

  constructor(private httpClient: HttpClient) { }

  ngOnInit() {
    this.getEventos();
  }
  public getEventos():void{
    this.httpClient.get('https://localhost:5001/api/eventos').subscribe(
      response=>{
        this.eventos = response,
        this.listaEventosFiltrada = this.eventos
      },
      error => console.log(error),
    );
  }

}

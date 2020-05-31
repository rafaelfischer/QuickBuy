import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';

@Component({
  selector: 'app-produto',
  templateUrl: './produto.component.html'
})
export class ProdutoComponent {
  public produtos: Produto[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Produto[]>(baseUrl + 'api/produto').subscribe(result => {
      this.produtos = result;
    }, error => console.error(error));
  }
}

interface Produto {
  id: string;
  nome: number;
  descricao: number;
  preco: string;
}

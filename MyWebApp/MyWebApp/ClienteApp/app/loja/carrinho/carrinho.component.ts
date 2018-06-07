import { Component, OnInit } from "@angular/core"
import { DataService } from "../../servicos/dataService";
import { Produto } from "../../modelos/produto"

@Component({
    selector: "carrinho",
    templateUrl: "./carrinho.component.html",
    styleUrls: []
})

export class Carrinho implements OnInit {
    constructor(private data: DataService) {
        this.produtos = data.produtos;
    }

    public produtos: Produto[];

    ngOnInit(): void {
        this.data.carregarProdutos().subscribe(() => this.produtos = this.data.produtos);
    }
}
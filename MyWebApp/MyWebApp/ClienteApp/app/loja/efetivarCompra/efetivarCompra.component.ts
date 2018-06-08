import { Component } from '@angular/core';
import { DataService } from '../../servicos/dataService';
import { Router } from "@angular/router";

@Component({
    selector: "efetivar",
    templateUrl: "efetivarCompra.component.html",
    styleUrls:[]
})
export class EfetivarCompra {
    mensagem: string;
    constructor(private data: DataService, public router: Router) {

    }

    onEfetivarCompra() {
        this.data.efetivarCompra()
            .subscribe(sucesso => {
                if (sucesso) {
                    this.router.navigate([""]);
                }
            }, erro => {
                this.mensagem = "Falhar ao salvar pedido";
            })
    }
}
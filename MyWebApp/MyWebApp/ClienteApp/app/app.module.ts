import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { AppComponent } from './app.component';
import { ListaProduto } from './loja/listaProduto.component'
import { DataService } from './servicos/dataService';
import { Carrinho } from './loja/carrinho/carrinho.component';

@NgModule({
    declarations: [
        AppComponent,
        ListaProduto,
        Carrinho
    ],
    imports: [
        BrowserModule,
        HttpModule
    ],
    providers: [DataService],
    bootstrap: [AppComponent]
})
export class AppModule { }

import React, { Component } from 'react';
import { FetchData } from './FetchData';

export class Home extends Component {
  static displayName = Home.name;    

    render() {
        const promise = fetch('api/QAs');
        promise.then(data => data.json())
            .then(data => {
                console.log(data);
                for (let i = 0; i < data.length; i++){
                    let q = data[i].question;
                    let a = data[i].answer;
                    let id = data[i].id;
                    let tid = data[i].time;
                    const ut = document.getElementById("FAQboks");
                    ut.insertAdjacentHTML("beforeend", 
                        '<div>' +
                        '<div class = "oversikt container-fluid">' +
                            '<div class="row">' +
                                '<div class="col-md-6">ID:'+id+'</div>' +
                                '<div class="col-md-6">Tidspunkt:'+tid+'</div>' +
                                '<div class="col-md-6">Q::'+q+' </div>' +
                                '<div class="col-md-6">A:'+a+'</div>' +
                            '</div>'+
                        '</div>'+
                        '</div>'
                        );
                }
            });
    return (
        
      <div id="FAQboks">
            <h1>Velkommen til F.A.Q</h1>
            <p>Her skjer det ting!</p>
      </div>
    );
    }
}

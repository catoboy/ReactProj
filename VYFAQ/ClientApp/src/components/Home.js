import React, { Component } from 'react';
import { Rating } from './Rating';


export class Home extends Component {
  static displayName = Home.name;
  
  constructor(props) {
        super(props);
        this.state = {
            data: [],
        };
    }
    
    componentDidMount() {
        fetch("api/QAs")
            .then(response => response.json())
            .then(responseJson => {
                this.setState({data: responseJson});
                console.log(this.state);
            })
            .catch(error => {
                console.error(error)
            });
       
    }
    
    render() {
    return (
        <div className="container-fluid">
            <h1 className="text-center">Ofte stilte spørsmål</h1>
            {this.state.data.map((obj, i) => {
                return (
                    <div key={i} className="card text-white bg-dark mb-3">
                        <div id={obj.id} className="card-header">{obj.id}</div>
                        <div className="card-body">
                            <h5 className="card-title text-center">Q:{obj.question}</h5>
                            <blockquote className="blockquote text-center">
                                <p className="">A: {obj.answer}</p>
                                <footer className="blockquote-footer">F.A.Q fra <cite title="Source Title">VY.no</cite>
                                </footer>
                            </blockquote>
                            <p>Tidpunkt: {obj.time}</p>
                            <Rating rating={obj.rating} RatingId={obj.id}/>
                        </div>
                    </div>
                )
            })}
        </div>
    );
    }
}

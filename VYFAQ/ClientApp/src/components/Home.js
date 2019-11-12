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
            <h1>Velkommen</h1>
            {this.state.data.map((obj, i) => {
                return (
                    <div key={i} className="card text-white bg-dark mb-3">
                        <div id={obj.id} className="card-header">{obj.id}</div>
                        <div className="card-body">
                            <h5 className="card-title">Q:{obj.question}</h5>
                            <p>A: {obj.answer}</p>
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

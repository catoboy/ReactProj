import React, { Component } from 'react';
import axios from "axios"; 

export class Rating extends Component {

    ratingHandler(id, rating) {
        axios.put('api/QAs/' + id + '?rating=' + rating)
            .then(responses => {
                console.log(responses)
            })
            .catch(error => {
                console.log(error)
            })
        window.location.reload(false)
    }

    render() {
        return (

            <div className="row">
                <div className="col-md-4 text-right">
                    <button className="btn btn-success" onClick={() => this.ratingHandler(this.props.RatingId, 1)}>Up</button>
                </div>
                <div className="col-md-4 text-center">
                    <p>{this.props.rating}</p>
                </div>
                <div className="col-md-4 text-left">
                    <button className="btn btn-danger" onClick={() => this.ratingHandler(this.props.RatingId, -1)}>Down</button>
                </div>
            </div>
            )
    }

}
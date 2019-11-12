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

            <div>
                <button onClick={() => this.ratingHandler(this.props.RatingId, 1)}>Up</button>
                <p className = "text-white">{this.props.rating}</p>
                <button onClick={() => this.ratingHandler(this.props.RatingId, -1)}>Down</button>
            </div>
            )
    }

}
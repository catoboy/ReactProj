import React, { Component } from 'react';
import axios from "axios";

export class SendInn extends Component {
    
    constructor(props){
        super(props);
        this.state = {
            data: [],
            firstname: '',
            lastname: '',
            email: '',
            question: ''
        }
    }

    componentDidMount() {
        fetch("api/innQAs")
            .then(response => response.json())
            .then(responseJson => {
                this.setState({ data: responseJson });
                console.log(this.state);
            })
            .catch(error => {
                console.error(error)
            });
    }

    changeHandler = (event) => {
        const {name, value} = event.target;

        this.setState({
            [name] : value
        })
    };

    submitQ = (event) => {
        event.preventDefault();
        axios.post('api/innQAs', this.state)
            .then(response => {
                this.setState({
                    firstname: '',
                    lastname: '',
                    email: '',
                    question: '',
                    time: '1500',
                })
            })
            .catch(error => {
                console.log(error)
            })
        window.location.reload(false)
    };
    
    render() {
        return (
            <div>
                <form action="" onSubmit={this.submitQ}>
                    <input
                        type="text"
                        value={this.state.firstname}
                        name="firstname"
                        onChange={this.changeHandler}
                        placeholder="Fornavn"
                        className="form-control"
                    />
                    <input
                        type="test"
                        value={this.state.lastname}
                        name="lastname"
                        onChange={this.changeHandler}
                        placeholder="Etternavn"
                        className="form-control"
                    />
                    <input
                        type="email"
                        value={this.state.email}
                        name="email"
                        onChange={this.changeHandler}
                        placeholder="E-mail"
                        className="form-control"
                    />
                    <div className="input-group">
                        <div className="input-group-prepend">
                            <span className="input-group-text">Spør her:</span>
                        </div>
                        <textarea
                            className="endreHeigth form-control"
                            value={this.state.question}
                            name="question"
                            onChange={this.changeHandler}
                            placeholder="Spørsmål"
                        />
                    </div>
                    <button className="form-control btn btn-dark" type="submit" name="send">Send inn</button>
                </form>
                <div className="container-fluid">
                    <h1>Innsendte spørsmål</h1>
                    {this.state.data.map((obj, i) => {
                        return (
                            <div key={i} className="card text-white bg-dark mb-3">
                                <div id={obj.id} className="card-header">{obj.id}</div>
                                <div className="card-body">
                                    <h5 className="card-title">Q:{obj.question}</h5>
                                    <p>Fornavn: {obj.firstname}</p>
                                    <p>Etternavn: {obj.lastname}</p>
                                    <p>Email: {obj.email}</p>
                                    <p>Tidpunkt: {obj.time}</p>
                                </div>
                            </div>
                        )
                    })}
                </div>
            </div>
            )
    }
}

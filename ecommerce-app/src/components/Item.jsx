import React, { Component } from 'react'

class Item extends React.Component {
    render(){
        return(
            <div className='item'>
                <img src={"./img/" + this.props.item.img}/>
                <h2>{this.props.item.title}</h2>
                <h2>{this.props.item.desc}</h2>
                <h2>{this.props.item.category}</h2>
                <h2>{this.props.item.price}$</h2>
                <div className='add-to-card'>+</div>
            </div>
        )
    }
}

export default Item;
import { DatabaseDefaults } from "./DatabaseDefaults.js";

export class Recipe extends DatabaseDefaults{
  constructor(d){ // data
    super(d)
    this.title = d.title
    this.instructions = d.instructions
    this.img = d.img
    this.category = d.category
    this.creatorId = d.creatorId
    this.creator = d.creator

  }
}
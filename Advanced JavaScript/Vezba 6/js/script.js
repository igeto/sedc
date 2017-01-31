function Animal(name, kind, isCarnivore) {
	this.name = name;
	this.kind = kind;
	this.isCarnivore = isCarnivore;
	this.type = "meat";
}
Animal.prototype.eat = function (food) {
	if (this.isCarnivore) {
		if (food.type !== "meat") {
			throw Error("${this.name} cannot eat ${food.name}");
		}
		if (food.kind == this.kind) {
			throw Error(`${this.name} cannot eat itself`);
		}
		return `${this.name} is eating ${food.name}`;
	}
	if (!this.isCarnivore) {
		if (food.type !== "grass") {
			throw Error("${this.name} cannot eat ${food.name}");
		}
			return `${this.name} is eating ${food.name}`;
	}
};
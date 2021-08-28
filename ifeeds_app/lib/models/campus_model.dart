import 'dart:convert';

class CampusModel {
  int? id;
  String? nome;
  
  
  CampusModel({
    this.id,
    this.nome,
  });

  Map<String, dynamic> toMap() {
    return {
      'id': id,
      'nome': nome,
    };
  }

  factory CampusModel.fromMap(Map<String, dynamic> map) {
    return CampusModel(
      id: map['id'],
      nome: map['nome'],
    );
  }

  String toJson() => json.encode(toMap());

  factory CampusModel.fromJson(String source) =>
      CampusModel.fromMap(json.decode(source));
}

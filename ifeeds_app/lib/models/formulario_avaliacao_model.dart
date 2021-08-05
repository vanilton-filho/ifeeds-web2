import 'dart:convert';

class FormularioAvaliacaoModel {

  int? id;
  String? titulo;
  String? descricao;
  
  FormularioAvaliacaoModel({
    this.id,
    this.titulo,
    this.descricao,
  });
  
  Map<String, dynamic> toMap() {
    return {
      'id': id,
      'titulo': titulo,
      'descricao': descricao,
    };
  }

  factory FormularioAvaliacaoModel.fromMap(Map<String, dynamic> map) {
    return FormularioAvaliacaoModel(
      id: map['id'],
      titulo: map['titulo'],
      descricao: map['descricao'],
    );
  }

  String toJson() => json.encode(toMap());

  factory FormularioAvaliacaoModel.fromJson(String source) => FormularioAvaliacaoModel.fromMap(json.decode(source));
}

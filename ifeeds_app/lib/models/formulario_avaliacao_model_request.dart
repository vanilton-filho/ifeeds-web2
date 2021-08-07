import 'dart:convert';
import 'dart:html';

class FormularioAvaliacaoModelRequest {

  String? titulo;
  String? descricao;
  double? nota;
  FormularioAvaliacaoModelRequest({
    this.titulo,
    this.descricao,
    this.nota,
  });

  Map<String, dynamic> toMap() {
    return {
      'titulo': titulo,
      'descricao': descricao,
      'nota': nota,
    };
  }

  factory FormularioAvaliacaoModelRequest.fromMap(Map<String, dynamic> map) {
    return FormularioAvaliacaoModelRequest(
      titulo: map['titulo'],
      descricao: map['descricao'],
      nota: map['nota'],
    );
  }

  String toJson() => json.encode(toMap());

  factory FormularioAvaliacaoModelRequest.fromJson(String source) => 
    FormularioAvaliacaoModelRequest.fromMap(json.decode(source));
}

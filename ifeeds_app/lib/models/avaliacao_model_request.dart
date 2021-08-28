import 'dart:convert';

class AvaliacaoModelRequest {
  String? nome;
  int? categoriaId;
  int? campusId;

  AvaliacaoModelRequest({
    this.nome,
    this.categoriaId,
    this.campusId,
  });

  Map<String, dynamic> toMap() {
    return {
      'nome': nome,
      'categoriaId': categoriaId,
      'campusId': campusId,
    };
  }

  factory AvaliacaoModelRequest.fromMap(Map<String, dynamic> map) {
    return AvaliacaoModelRequest(
      nome: map['nome'],
      categoriaId: map['categoriaId'],
      campusId: map['campusId'],
    );
  }

  String toJson() => json.encode(toMap());

  factory AvaliacaoModelRequest.fromJson(String source) =>
      AvaliacaoModelRequest.fromMap(json.decode(source));
}

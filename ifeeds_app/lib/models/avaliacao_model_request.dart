import 'dart:convert';

class AvaliacaoModelRequest {
  String? titulo;
  int? categoriaId;
  int? campusId;

  AvaliacaoModelRequest({
    this.titulo,
    this.categoriaId,
    this.campusId,
  });

  Map<String, dynamic> toMap() {
    return {
      'titulo': titulo,
      'categoriaId': categoriaId,
      'campusId': campusId,
    };
  }

  factory AvaliacaoModelRequest.fromMap(Map<String, dynamic> map) {
    return AvaliacaoModelRequest(
      titulo: map['titulo'],
      categoriaId: map['categoriaId'],
      campusId: map['campusId'],
    );
  }

  String toJson() => json.encode(toMap());

  factory AvaliacaoModelRequest.fromJson(String source) =>
      AvaliacaoModelRequest.fromMap(json.decode(source));
}

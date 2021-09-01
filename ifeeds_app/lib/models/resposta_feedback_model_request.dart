import 'dart:convert';

class RespostaFeedbackModelRequest {
  String? resposta;
  int? feedbackId;
  int? usuarioId;

  RespostaFeedbackModelRequest({
    this.resposta,
    this.feedbackId,
    this.usuarioId,
  });

  Map<String, dynamic> toMap() {
    return {
      'resposta': resposta,
      'feedbackId': feedbackId,
      'usuarioId': usuarioId,
    };
  }

  factory RespostaFeedbackModelRequest.fromMap(Map<String, dynamic> map) {
    return RespostaFeedbackModelRequest(
      resposta: map['resposta'],
      feedbackId: map['feedbackId'],
      usuarioId: map['usuarioId'],
    );
  }

  String toJson() => json.encode(toMap());

  factory RespostaFeedbackModelRequest.fromJson(String source) =>
      RespostaFeedbackModelRequest.fromMap(json.decode(source));
}

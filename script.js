/* ===================================================================
   HEART PROTOCOL - INTERACTIVE LOGIC & ANIMATIONS
   =================================================================== */

// --- CONFIG & PERSONALIZATION ---
const HerName = "Tuyết Mai";

const AcceptedNames = [
  "bình",
  "yên bình",
  "mai",
  "tuyết mai"
];

const First =
  "Ở đây em sẽ thành thật với cảm xúc của mình nhé chị.\n\n" +
  "Em thích được ở bên chị, thích cách chị quan tâm em, " +
  "những cái đụng chạm của chị, ánh mắt chị nhìn em " +
  "và cả nụ cười đi kèm nữa.\n\n" +
  "Không biết chị có nhận ra không, " +
  "nhưng từ lúc biết chị, em thấy vai mình nhẹ hơn một chút.\n\n" +
  "Có những hôm đi làm stress muốn điên, " +
  "nhưng gặp chị một cái là tự nhiên vơi đi phân nửa.\n\n" +
  "Rồi em bắt đầu thích được ở cạnh chị " +
  "nhiều hơn mức em tưởng.";

const Second =
  "Em cũng bắt đầu muốn biết nhiều hơn về một ngày của chị.\n\n" +
  "Hôm nay chị ăn chưa, có mệt không, có nhiều việc không, " +
  "có chuyện gì làm chị buồn không, tối qua chị ngủ đủ giấc không...\n\n" +
  "Những chuyện nhỏ vậy thôi mà tự nhiên em lại muốn biết.\n\n" +
  "Nhưng càng để ý thì em càng rén :))))\n\n" +
  "Có lúc em muốn chủ động tiến thêm một bước, " +
  "nhưng lại không chắc chị đang nhìn em như thế nào.\n\n";

const Last =
  "Em biết giữa chúng ta có khoảng cách.\n\n" +
  "Tuổi tác, trải nghiệm, cách nhìn cuộc sống " +
  "và cả những chuyện khó nói mà em nghĩ mình không nên tự ý bước vào " +
  "nếu chị chưa muốn kể.\n\n" +
  "Em cũng biết mình còn non, " +
  "chưa đủ trải đời để nói rằng em hiểu hết mọi thứ.\n\n" +
  "Nhưng nếu một ngày chị mệt và cần một người ngồi nghe chị ràm, " +
  "em nghe.\n\n" +
  "Nếu chị bận đến quên ăn, em nhắc chị ăn.\n" +
  "Nếu chị cần người đón đưa, em sẵn lòng.\n\n" +
  "Còn nếu có lúc chị chỉ cần một vòng tay " +
  "và không muốn nói gì cả...\n\n" +
  "em cũng muốn cho chị vòng tay đó.\n\n" +
  "Em không hứa mình có thể bù đắp những điều không vui đã qua.\n\n" +
  "Em chỉ muốn nếu chị cho phép, " +
  "em sẽ đem những gì tốt nhất em có đến cho chị.\n\n" +
  "Ở bên chị em không cần phải gồng và ngược lại.\n\n" +
  "Và em cũng muốn một ngày nào đó, " +
  "mình có thể trở thành một nơi đủ yên để chị dựa vào.";

const FinalMessageBeforeBoom =
  "Em đã tự hỏi mình khá nhiều lần.\n\n" +
  "Đây là quý chị, ngưỡng mộ chị, " +
  "hay chỉ vì được chị quan tâm nên em rung động?\n\n" +
  "Nhưng càng né thì em càng để ý.\n" +
  "Càng cố không nghĩ thì em lại càng nghĩ.\n\n" +
  "Đến lúc này em nhận ra...\n\n" +
  "Tuổi tác hay generation gap, 15-20 tuổi " +
  "không còn là thứ làm em băn khoăn nhất nữa.\n\n" +
  "Thứ làm em băn khoăn suy nghĩ nhiều nhất là chị.\n\n" +
  "'Ủa chỉ làm vậy là có ý gì?' , " +
  "'Ủa chỉ có thích mình không ta?' , " +
  "'Chị oi đùng nhìn em z nữa em ngại chết mất.' , " +
  "cũng không phải vì em thích cảm giác mình là ngoại lệ.\n\n" +
  "Mà vì chị khiến một ngày mệt mỏi của em nhẹ đi.\n" +
  "Và em thích chính mình khi ở cạnh chị.\n\n" +
  "Rồi chẳng biết từ lúc nào...";

const FinalMessageAfterBoom =
  "Em thích chị thật rồi :))))))\n\n" +
  "Không phải kiểu thích cho vui " +
  "hay một phút bốc đồng rồi mai quên.\n\n" +
  "Em muốn nghiêm túc bước thêm một bước về phía chị.\n\n" +
  "Nếu chị cũng có một chút cảm giác giống em, " +
  "thì cho em một cơ hội.\n\n" +
  "Còn nếu không, em vẫn tôn trọng chị, " +
  "tôn trọng câu trả lời của chị " +
  "và trân trọng những gì đã có giữa hai người.\n\n" +
  "Em chỉ không muốn giấu cảm xúc này mãi nữa.\n\n" +
  "Nên hôm nay em nói thật.\n\n" +
  "Em thích chị. ❤";

// --- UTILITIES ---
const sleep = (ms) => new Promise((resolve) => setTimeout(resolve, ms));

function normalizeName(input) {
  if (!input) return "";
  return input
    .trim()
    .toLowerCase()
    .replace(/\s+/g, " ");
}

// Auto scroll on mobile devices
function scrollToBottomSmooth() {
  window.scrollTo({
    top: document.documentElement.scrollHeight,
    behavior: "smooth"
  });
}

// --- TYPEWRITER EFFECT ---
async function typeText(element, text, delay = 32, autoScroll = false) {
  element.textContent = "";
  for (let i = 0; i < text.length; i++) {
    element.textContent += text[i];
    if (autoScroll && i % 15 === 0) scrollToBottomSmooth();
    await sleep(delay);
  }
}

async function appendText(element, text, delay = 32, autoScroll = false) {
  for (let i = 0; i < text.length; i++) {
    element.textContent += text[i];
    if (autoScroll && i % 15 === 0) scrollToBottomSmooth();
    await sleep(delay);
  }
}

// --- SCENE SWITCHER ---
async function switchScene(fromSceneId, toSceneId) {
  const fromScene = document.getElementById(fromSceneId);
  const toScene = document.getElementById(toSceneId);

  if (fromScene) {
    fromScene.style.opacity = "0";
    await sleep(300);
    fromScene.classList.remove("active");
  }

  if (toScene) {
    toScene.classList.add("active");
    window.scrollTo({ top: 0, behavior: "instant" });
    await sleep(50);
    toScene.style.opacity = "1";
  }
}

// --- AUDIO SYSTEM (WITH WEB AUDIO API SYNTHESIZER FALLBACK) ---
const boomAudio = document.getElementById("boomAudio");
let audioUnlocked = false;

function unlockAudio() {
  if (audioUnlocked) return;
  audioUnlocked = true;
  if (boomAudio) {
    boomAudio.volume = 0.9;
    boomAudio.play().then(() => {
      boomAudio.pause();
      boomAudio.currentTime = 0;
    }).catch(() => {});
  }
}

function playBoomSound() {
  if (boomAudio && boomAudio.readyState >= 2) {
    boomAudio.currentTime = 0;
    boomAudio.play().catch(() => playSyntheticBoom());
  } else {
    playSyntheticBoom();
  }
}

// Fallback boom synthesizer via Web Audio API
function playSyntheticBoom() {
  try {
    const AudioContext = window.AudioContext || window.webkitAudioContext;
    if (!AudioContext) return;
    const ctx = new AudioContext();
    const osc = ctx.createOscillator();
    const gain = ctx.createGain();

    osc.type = "sawtooth";
    osc.frequency.setValueAtTime(140, ctx.currentTime);
    osc.frequency.exponentialRampToValueAtTime(30, ctx.currentTime + 0.8);

    gain.gain.setValueAtTime(0.9, ctx.currentTime);
    gain.gain.exponentialRampToValueAtTime(0.01, ctx.currentTime + 0.8);

    osc.connect(gain);
    gain.connect(ctx.destination);

    osc.start();
    osc.stop(ctx.currentTime + 0.85);
  } catch (e) {
    console.log("Audio not supported", e);
  }
}

// --- FLOATING HEARTS CANVAS ENGINE ---
const canvas = document.getElementById("heartCanvas");
const ctx = canvas.getContext("2d");
let hearts = [];
let spawnHeartInterval = null;

function resizeCanvas() {
  canvas.width = window.innerWidth;
  canvas.height = window.innerHeight;
}
window.addEventListener("resize", resizeCanvas);
resizeCanvas();

class FloatingHeart {
  constructor(x, y, isBurst = false) {
    this.x = x !== undefined ? x : Math.random() * canvas.width;
    this.y = y !== undefined ? y : canvas.height + 20;
    this.size = Math.floor(Math.random() * 20) + 16;
    this.speedY = isBurst ? -(Math.random() * 6 + 3) : -(Math.random() * 2.2 + 1.2);
    this.speedX = isBurst ? (Math.random() - 0.5) * 8 : (Math.random() - 0.5) * 1.5;
    this.opacity = Math.random() * 0.5 + 0.45;
    this.decay = Math.random() * 0.005 + 0.004;
    this.rotation = Math.random() * Math.PI * 2;
    this.rotSpeed = (Math.random() - 0.5) * 0.04;
    this.color = Math.random() > 0.3 ? "#FF3158" : "#FF6B8B";
  }

  update() {
    this.y += this.speedY;
    this.x += this.speedX;
    this.opacity -= this.decay;
    this.rotation += this.rotSpeed;
  }

  draw() {
    if (this.opacity <= 0) return;
    ctx.save();
    ctx.globalAlpha = Math.max(0, this.opacity);
    ctx.translate(this.x, this.y);
    ctx.rotate(this.rotation);
    ctx.fillStyle = this.color;
    ctx.font = `${this.size}px "Segoe UI Symbol", sans-serif`;
    ctx.textAlign = "center";
    ctx.textBaseline = "middle";
    ctx.shadowColor = "rgba(255, 49, 88, 0.6)";
    ctx.shadowBlur = 10;
    ctx.fillText("❤", 0, 0);
    ctx.restore();
  }
}

function spawnBurst(count, centerX, centerY) {
  const originX = centerX !== undefined ? centerX : canvas.width / 2;
  const originY = centerY !== undefined ? centerY : canvas.height / 2;
  for (let i = 0; i < count; i++) {
    hearts.push(new FloatingHeart(originX + (Math.random() - 0.5) * 120, originY + (Math.random() - 0.5) * 80, true));
  }
}

function animateHearts() {
  ctx.clearRect(0, 0, canvas.width, canvas.height);
  for (let i = hearts.length - 1; i >= 0; i--) {
    hearts[i].update();
    hearts[i].draw();
    if (hearts[i].opacity <= 0 || hearts[i].y < -50) {
      hearts.splice(i, 1);
    }
  }
  requestAnimationFrame(animateHearts);
}
animateHearts();

function startHeartSpawnTimer(intervalMs = 260) {
  if (spawnHeartInterval) clearInterval(spawnHeartInterval);
  spawnHeartInterval = setInterval(() => {
    hearts.push(new FloatingHeart());
  }, intervalMs);
}

function stopHeartSpawnTimer() {
  if (spawnHeartInterval) {
    clearInterval(spawnHeartInterval);
    spawnHeartInterval = null;
  }
}

// ===================================================================
// SCENE 1: LOGIN
// ===================================================================
const nameInput = document.getElementById("nameInput");
const loginBtn = document.getElementById("loginBtn");
const loginStatus = document.getElementById("loginStatus");
let isTransitioning = false;

async function checkIdentity() {
  if (isTransitioning) return;
  unlockAudio();

  const entered = normalizeName(nameInput.value);

  if (!entered) {
    loginStatus.className = "status-msg error";
    loginStatus.textContent = "Nhập tên của chị vào đi mò.";
    nameInput.focus();
    return;
  }

  const isCorrect = AcceptedNames.some((n) => normalizeName(n) === entered);

  if (!isCorrect) {
    loginStatus.className = "status-msg error";
    loginStatus.textContent =
      "Ôi rất tiếc, người có thể vào được 'choái tym' này không phải chị rồi huhuhuh.\n" +
      "Mình hỏng cóa duyên ròi huhuhuhu";
    nameInput.select();
    return;
  }

  isTransitioning = true;
  loginStatus.className = "status-msg success";
  loginStatus.textContent =
    "ÔI TÌNH YÊU CỤA EM TỚI ỒI.\n" +
    "ĐI TÌM TÌNH YÊU THOIIII...";

  loginBtn.disabled = true;
  nameInput.disabled = true;

  await sleep(1100);
  await switchScene("sceneLogin", "sceneBoot");
  runBootSequence();
}

loginBtn.addEventListener("click", checkIdentity);
nameInput.addEventListener("keydown", (e) => {
  if (e.key === "Enter") checkIdentity();
});

// ===================================================================
// SCENE 2: BOOT
// ===================================================================
const bootText = document.getElementById("bootText");
const bootTerminalArea = document.getElementById("bootTerminalArea");
const bootTapHint = document.getElementById("bootTapHint");
let bootReady = false;

let typingBoot = false;
let bootFullText = "";

async function runBootSequence() {
  typingBoot = true;
  bootReady = false;
  isTransitioning = false;

  const bootMsg =
    "Hế lu chị.\n\n" +
    "Đang khởi tạo...\n" +
    "Đang tải dữ liệu...\n" +
    "Đang kiểm tra...\n\n" +
    "Chờ em mụt chíu nhó.";

  const finalMsg =
    "\n\nCHƯƠNG TRÌNH ĐÃ SẴN SÀNG.\n\nNhấn để tiếp tục.";

  bootFullText = bootMsg + finalMsg;

  // Type first part
  await typeText(bootText, bootMsg, 24);
  if (!typingBoot) return; // user skipped
  await sleep(650);

  // Type second part
  if (!typingBoot) return;
  await appendText(bootText, finalMsg, 24);

  typingBoot = false;
  bootReady = true;
  isTransitioning = false;
  bootTapHint.classList.add("show");

  const bootContinueBtn = document.getElementById("bootContinueBtn");
  if (bootContinueBtn) {
    bootContinueBtn.style.display = "inline-flex";
  }
}

function skipBootTyping() {
  if (typingBoot) {
    typingBoot = false;
    bootText.textContent = bootFullText;
    bootReady = true;
    isTransitioning = false;
    bootTapHint.classList.add("show");
    const bootContinueBtn = document.getElementById("bootContinueBtn");
    if (bootContinueBtn) {
      bootContinueBtn.style.display = "inline-flex";
    }
    return true;
  }
  return false;
}

async function proceedFromBoot(e) {
  if (e) {
    if (e.stopPropagation) e.stopPropagation();
  }

  // If still typing, clicking once will immediately finish the text!
  if (typingBoot) {
    skipBootTyping();
    return;
  }

  if (isTransitioning) return;
  isTransitioning = true;
  await switchScene("sceneBoot", "sceneScan");
  await runScanSequence();
  isTransitioning = false;
}

const bootContinueBtn = document.getElementById("bootContinueBtn");
if (bootContinueBtn) {
  bootContinueBtn.addEventListener("click", proceedFromBoot);
  bootContinueBtn.addEventListener("touchend", proceedFromBoot);
}
bootTerminalArea.addEventListener("click", proceedFromBoot);
bootTerminalArea.addEventListener("touchend", proceedFromBoot);

const sceneBootEl = document.getElementById("sceneBoot");
if (sceneBootEl) {
  sceneBootEl.addEventListener("click", proceedFromBoot);
  sceneBootEl.addEventListener("touchend", proceedFromBoot);
}

// Global click/touch listener when in sceneBoot
window.addEventListener("click", (e) => {
  const sceneBoot = document.getElementById("sceneBoot");
  if (sceneBoot && sceneBoot.classList.contains("active") && !isTransitioning) {
    proceedFromBoot(e);
  }
});
window.addEventListener("touchend", (e) => {
  const sceneBoot = document.getElementById("sceneBoot");
  if (sceneBoot && sceneBoot.classList.contains("active") && !isTransitioning) {
    proceedFromBoot(e);
  }
});

// ===================================================================
// SCENE 3: SCAN
// ===================================================================
const scanProgressFill = document.getElementById("scanProgressFill");
const scanPercent = document.getElementById("scanPercent");
const scanWarning = document.getElementById("scanWarning");
const processInfo = document.getElementById("processInfo");
const inspectGroup = document.getElementById("inspectGroup");
const inspectBtn = document.getElementById("inspectBtn");

async function runScanSequence() {
  const steps = [12, 37, 68, 91, 100];
  scanProgressFill.style.width = "0%";
  scanProgressFill.classList.remove("crimson");

  for (const percent of steps) {
    scanProgressFill.style.width = percent + "%";
    scanPercent.textContent = percent + "%";
    await sleep(430);
  }

  await sleep(350);
  scanProgressFill.classList.add("crimson");
  scanWarning.classList.add("show");

  await sleep(650);

  const processDetails =
    "Tiến trình: NGUOI_AY_LA_AI.exe\n\n" +
    "Mức sử dụng CPU:       45%\n" +
    "Mức sử dụng bộ nhớ:    82%\n" +
    "Chiếm dụng trái tim:  100%";

  await typeText(processInfo, processDetails, 25);
  await sleep(900);

  inspectGroup.classList.add("show");
  isTransitioning = false;
}

inspectBtn.addEventListener("click", async () => {
  inspectBtn.disabled = true;
  await switchScene("sceneScan", "sceneHeart");
  initHeartScene();
});

// ===================================================================
// SCENE 4: HEART
// ===================================================================
const bigHeart = document.getElementById("bigHeart");
let heartOpened = false;

function initHeartScene() {
  spawnBurst(28, canvas.width / 2, canvas.height / 2);
  startHeartSpawnTimer(260);
}

bigHeart.addEventListener("click", async () => {
  if (heartOpened) return;
  heartOpened = true;
  stopHeartSpawnTimer();

  const rect = bigHeart.getBoundingClientRect();
  spawnBurst(45, rect.left + rect.width / 2, rect.top + rect.height / 2);

  await sleep(550);
  await switchScene("sceneHeart", "sceneMemory");
});

// ===================================================================
// SCENE 5: MEMORY
// ===================================================================
const memBtn1 = document.getElementById("memBtn1");
const memBtn2 = document.getElementById("memBtn2");
const memBtn3 = document.getElementById("memBtn3");
const memoryContent = document.getElementById("memoryContent");
const memContinueBtn = document.getElementById("memContinueBtn");
const analysisDoneText = document.getElementById("analysisDoneText");
let memoryBusy = false;

async function handleMemoryClick(button, tag) {
  if (memoryBusy || button.disabled) return;
  memoryBusy = true;
  button.disabled = true;

  let textToDisplay = "";
  if (tag === "1") textToDisplay = First;
  else if (tag === "2") textToDisplay = Second;
  else textToDisplay = Last;

  await typeText(memoryContent, button.textContent + "\n\n" + textToDisplay, 20, true);

  if (tag === "1") memBtn2.disabled = false;
  if (tag === "2") memBtn3.disabled = false;

  memoryBusy = false;

  if (tag === "3") {
    await sleep(350);
    memContinueBtn.style.display = "inline-flex";
    await sleep(50);
    memContinueBtn.style.opacity = "1";
    scrollToBottomSmooth();
  }
}

memBtn1.addEventListener("click", () => handleMemoryClick(memBtn1, "1"));
memBtn2.addEventListener("click", () => handleMemoryClick(memBtn2, "2"));
memBtn3.addEventListener("click", () => handleMemoryClick(memBtn3, "3"));

memContinueBtn.addEventListener("click", async () => {
  memContinueBtn.disabled = true;
  memContinueBtn.style.opacity = "0";
  await sleep(250);
  memContinueBtn.style.display = "none";

  analysisDoneText.style.display = "block";
  await sleep(50);
  analysisDoneText.style.opacity = "1";

  await sleep(900);
  await switchScene("sceneMemory", "sceneDecrypt");
  runDecryptSequence();
});

// ===================================================================
// SCENE 6: DECRYPT
// ===================================================================
const decryptTerminal = document.getElementById("decryptTerminal");
const decryptProgressWrap = document.getElementById("decryptProgressWrap");
const decryptProgressFill = document.getElementById("decryptProgressFill");
const decryptBarText = document.getElementById("decryptBarText");
const secretBtn = document.getElementById("secretBtn");

async function runDecryptSequence() {
  await typeText(decryptTerminal, "Đang tìm kiếm...", 30);
  await sleep(650);

  await appendText(decryptTerminal, "\n\nĐã tìm thấy 1 kết quả phù hợp.", 30);
  await sleep(700);

  await appendText(decryptTerminal, "\n\nĐang giải mã...", 30);
  decryptProgressWrap.style.display = "block";
  await sleep(350);

  for (let percent = 0; percent <= 100; percent += 5) {
    decryptProgressFill.style.width = percent + "%";
    const blocks = percent / 5;
    const bar = "█".repeat(blocks) + "░".repeat(20 - blocks);
    decryptBarText.textContent = `${bar} ${percent}%`;
    await sleep(55);
  }

  await sleep(650);
  await appendText(decryptTerminal, "\n\nĐÃ XÁC ĐỊNH NGUYÊN NHÂN:", 30);
  await sleep(500);

  secretBtn.style.display = "inline-flex";
  scrollToBottomSmooth();
}

secretBtn.addEventListener("click", async () => {
  secretBtn.disabled = true;
  document.getElementById("buildStamp").style.display = "block";
  await switchScene("sceneDecrypt", "sceneFinal");
  runFinalSequence();
});

// ===================================================================
// SCENE 7: FINAL CONFESSION
// ===================================================================
const finalIntro = document.getElementById("finalIntro");
const finalLead = document.getElementById("finalLead");
const herNameDisplay = document.getElementById("herNameDisplay");
const finalLove = document.getElementById("finalLove");
const boomBanner = document.getElementById("boomBanner");
const finalAfterBoom = document.getElementById("finalAfterBoom");
const finalQuestion = document.getElementById("finalQuestion");
const finalActions = document.getElementById("finalActions");
const yesBtn = document.getElementById("yesBtn");
const thinkBtn = document.getElementById("thinkBtn");
const finalStatusResult = document.getElementById("finalStatusResult");

async function runFinalSequence() {
  await typeText(finalIntro, "Thật ra...\n\nem đã muốn nói điều này\ntừ khá lâu rồi.", 38, true);
  await sleep(950);

  await typeText(finalLead, "Người làm 'bộ nhớ' của em\nthường xuyên bị 'tràn' là...", 40, true);
  await sleep(1100);

  herNameDisplay.textContent = HerName;
  herNameDisplay.style.display = "block";
  await sleep(50);
  herNameDisplay.style.opacity = "1";
  scrollToBottomSmooth();

  await sleep(1300);
  await typeText(finalLove, FinalMessageBeforeBoom, 32, true);
  await sleep(1000);

  // Climax: Sound & Explosion banner
  playBoomSound();
  boomBanner.style.display = "block";
  spawnBurst(35, canvas.width / 2, canvas.height / 2);
  scrollToBottomSmooth();

  await sleep(1100);
  await typeText(finalAfterBoom, FinalMessageAfterBoom, 34, true);
  await sleep(900);

  await typeText(finalQuestion, "Vậy... chị có muốn cho em một cơ hội không? ❤", 35, true);
  await sleep(500);

  finalActions.style.display = "flex";
  scrollToBottomSmooth();
}

// YES CLICK
yesBtn.addEventListener("click", async () => {
  yesBtn.disabled = true;
  thinkBtn.disabled = true;

  finalStatusResult.style.color = "var(--color-crimson)";
  finalStatusResult.textContent = "OMG, SHE SAID YESSSSS ❤";
  scrollToBottomSmooth();

  for (let i = 0; i < 75; i++) {
    hearts.push(new FloatingHeart(Math.random() * canvas.width, canvas.height + 20, false));
    if (i % 10 === 0) await sleep(25);
  }

  await sleep(1200);
  showDevNoteModal();
});

// THINK / NO CLICK
thinkBtn.addEventListener("click", async () => {
  yesBtn.disabled = true;
  thinkBtn.disabled = true;

  finalStatusResult.style.color = "var(--color-green)";
  finalStatusResult.textContent = "Không sao đâu :>\n\nEm vẫn trân trọng chị và câu trả lời này. ❤";
  scrollToBottomSmooth();

  await sleep(1200);
  showDevNoteModal();
});

// ===================================================================
// SCENE 8: DEVELOPER NOTE OVERLAY
// ===================================================================
const devNoteModal = document.getElementById("devNoteModal");
const closeModalBtn = document.getElementById("closeModalBtn");

function showDevNoteModal() {
  devNoteModal.classList.add("active");
}

closeModalBtn.addEventListener("click", () => {
  devNoteModal.classList.remove("active");
});
